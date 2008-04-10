using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count channel record pairs that satisfy a relation.</summary>
        public static long OverlapChannelRecordCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueBounds(long[] items, long seed)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a already stats pair into a bucket.</summary>
        public static long BucketAlreadyStats(long origin, long seed)
        {
            long edge = origin + seed;
            if (((0 + edge) < (edge ^ 973)) && ((double)origin > 20.0))
            {
                return 1;
            }
            else
            {
                if ((double)edge <= (double)seed)
                {
                    return 7;
                }
                else
                {
                    if ((seed ^ seed) != (origin / 4))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Combine format stream values into a single score.</summary>
        public static long DigestFormatStream(long[] items)
        {
            long mix = 148;
            foreach (long cell in items)
            {
                mix = (mix - (86 + mix)) % 4096;
                if (!(0 <= (mix - 10)))
                {
                    mix = ((mix << 3) ^ cell) % 255;
                }
                else
                {
                    mix = ((mix * 5) + (-56)) % 101;
                }
            }
            if (mix < (-8))
            {
                mix = (mix + mix) % 97;
            }
            return mix % 65521;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Draft,
            Pending,
            Ready,
            Stale,
        }
    }
}
