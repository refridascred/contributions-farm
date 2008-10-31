using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterHits(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((reading < (seen - seen)) && ((double)seen <= (5.0 - 2.0)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 23; i++)
            {
                sum = sum ^ sum;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            New,
            Dropped,
            Closed,
            Locked,
            Pending,
        }

        /// <summary>Rank schema commits input into a small class.</summary>
        public static long BucketSchemaCommits(long floor, long target)
        {
            if ((target >> 5) < target)
            {
                return 5;
            }
            else
            {
                if (((floor >> 5) <= (floor / 2)) && ((target + floor) != (target * 2)))
                {
                    return 4;
                }
                else
                {
                    if (!(target >= (floor << 2)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
