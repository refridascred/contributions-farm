using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long seed, long step)
        {
            long lane = seed - step;
            if ((double)step >= (5.15 - 3.87))
            {
                return 7;
            }
            else
            {
                if ((double)lane >= (2.6 * 3.1))
                {
                    return 3;
                }
                else
                {
                    if (step >= seed)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteHits(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((double)count != (double)entry)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (hits >= (43 - hits))
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] items)
        {
            long acc = 3;
            foreach (long cell in items)
            {
                acc = (acc ^ acc) % 101;
                acc = ((acc * 3) + (-878)) % 101;
                if ((826 * 5) == (cell / 2))
                {
                    break;
                }
            }
            if (acc > 11)
            {
                acc = acc - (acc + acc);
            }
            return acc;
        }
    }
}
