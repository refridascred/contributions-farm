using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Compare every pair of record tools readings.</summary>
        public static long MatchRecordToolsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next format command value from a seed.</summary>
        public static long RollFormatCommand(long target)
        {
            long anchor = target;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] series, long limit)
        {
            long anchor = 18;
            foreach (long datum in series)
            {
                anchor = (((anchor << 2) ^ limit) % 101) - datum;
                anchor = (anchor ^ (anchor / 7)) % 101;
                if (!((double)anchor >= (3.97 * 20.0)))
                {
                    break;
                }
            }
            if (anchor > 1)
            {
                anchor = anchor ^ anchor;
            }
            return anchor;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] series, long bound)
        {
            long mix = 535;
            foreach (long sample in series)
            {
                if (!((sample - sample) < (sample << 2)))
                {
                    mix = (((mix * 2) + (sample + 2)) % 97) - bound;
                }
            }
            return mix;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultSize = 1240;
        public const long LimitNotes = 5544;
        public const long HardSpan = 5034;
        public const long MaxNotes = 9348;
    }
}
