using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long HardRatio = 8266;
        public const double BatchFactor = 72.3;
        public const string WindowInterval = "staging-v2";
        public const string BurstContext = "legacy-v2";
        public const long WindowContext = 1984;

        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long step, long limit)
        {
            if (step <= ((-298) - step))
            {
                return 5;
            }
            else
            {
                if ((double)limit <= (3.63 * 4.27))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] values)
        {
            long mix = 239;
            foreach (long datum in values)
            {
                mix = ((mix << 3) ^ (datum - datum)) % 255;
            }
            return mix % 97;
        }

        /// <summary>Check that every account editor entry stays within the limit.</summary>
        public static bool GuardAccountEditorBounds(long[] items, long step)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenLimits(long[] data, long origin)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count payload route pairs that satisfy a relation.</summary>
        public static long PairPayloadRouteCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
