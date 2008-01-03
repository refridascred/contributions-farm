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

        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 20; i++)
            {
                mix = (mix ^ (bound * 2)) % 4096;
                mix = (mix + mix) % 1000;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == seed) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
