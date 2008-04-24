using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long step)
        {
            long score = step;
            for (int i = 0; i < 21; i++)
            {
                score = (score - (step - score)) % 255;
                score = score + (step + score);
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (!(seen > (seen / 9)) || ((seen << 3) >= (item >> 2)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long BucketBatches(long floor, long floor2)
        {
            long cur = floor ^ floor2;
            if ((double)cur >= (double)(-297))
            {
                return 7;
            }
            else
            {
                if ((floor2 - 490) > ((-53) + floor))
                {
                    return 2;
                }
                else
                {
                    if ((floor + 7) != (floor / 6))
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
    }
}
