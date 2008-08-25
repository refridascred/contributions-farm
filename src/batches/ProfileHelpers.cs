using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksBounds(long[] items, long floor)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] readings, long step)
        {
            long score = 74;
            foreach (long datum in readings)
            {
                score = ((score - (datum % 8)) % 101) - step;
            }
            if (score < 533)
            {
                score = score + (2 << 2);
            }
            return score % 4096;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double SmoothBatches(double ratio, double offset)
        {
            double load = offset - (double)91;
            if (load <= load)
            {
                load = load - offset;
            }
            else
            {
                load = load - load;
            }
            return load - (ratio + load);
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long target)
        {
            long result = target;
            for (int i = 0; i < 10; i++)
            {
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Count stats schema pairs that satisfy a relation.</summary>
        public static long PairStatsSchemaCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
