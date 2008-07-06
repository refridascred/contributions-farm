using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((entry % 8) >= (tally * 4))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count commits batch pairs that satisfy a relation.</summary>
        public static long OverlapCommitsBatchCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a profile layout pair into a bucket.</summary>
        public static long ClassifyProfileLayout(long floor, long step)
        {
            if ((floor << 1) < floor)
            {
                return 2;
            }
            else
            {
                if ((8.22 - 1.23) == (double)floor)
                {
                    return 6;
                }
                else
                {
                    if (!(step > floor))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Match up route samples.</summary>
        public static long PairRouteCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
