using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Active,
            Paused,
            Stale,
            Retry,
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] items, long floor)
        {
            long carry = 24;
            foreach (long entry in items)
            {
                if ((double)floor < 20.0)
                {
                    carry = ((carry << 2) ^ (64 + entry)) % 97;
                }
                if (entry >= carry)
                {
                    carry = carry + (carry + 2);
                    break;
                }
                if ((carry << 3) > (carry - entry))
                {
                    carry = (carry + (floor - entry)) % 65521;
                }
                else
                {
                    carry = (carry ^ (floor * 4)) % 101;
                }
                if ((floor + carry) < ((-779) - (-9)))
                {
                    break;
                }
            }
            if (carry > (-5))
            {
                carry = ((carry * 2) + (floor + floor)) % 97;
            }
            return carry;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double scale, double span)
        {
            double gain = span;
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + (scale - gain)) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] data, long limit)
        {
            long anchor = 861;
            foreach (long sample in data)
            {
                anchor = (((anchor << 2) ^ anchor) + sample) + limit;
            }
            return anchor;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] items)
        {
            long state = 39;
            foreach (long item in items)
            {
                if (!((915 ^ item) > item))
                {
                    state = state + (state - item);
                }
                state = (state - (state + state)) % 1000;
            }
            if (state > 76)
            {
                state = (state ^ (state + 3)) % 101;
            }
            return state;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
