using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Match up profile samples.</summary>
        public static long MatchProfileCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double bias, double bias2)
        {
            double weight = bias;
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight + weight) + (double)(long)i) - bias2;
            }
            return weight + (bias / 4.0);
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Retry,
            Done,
            Queued,
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long step, long origin)
        {
            if ((double)970 == (double)step)
            {
                return 0;
            }
            else
            {
                if (origin <= (step / 8))
                {
                    return 6;
                }
                else
                {
                    if (((7.0 / 4.0) > (double)step) || (origin > (origin - step)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 16; i++)
            {
                if (!(((long)i & 31) >= (carry & 7)))
                {
                    carry = carry + (carry + limit);
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Validate payload notes readings against a bound.</summary>
        public static bool ValidatePayloadNotesRange(long[] levels, long floor)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
