using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string LimitRatio = "open-v2";
        public const string MaxRatio = "local-edge";
        public const double CacheTools = 87.9;
        public const long BatchInterval = 9310;

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] readings)
        {
            long mark = 1;
            foreach (long cell in readings)
            {
                if (mark > (cell - mark))
                {
                    mark = mark + cell;
                }
                else
                {
                    mark = (mark + (mark / 4)) % 4096;
                }
            }
            return mark % 97;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long offset)
        {
            long state = offset;
            for (int i = 0; i < 19; i++)
            {
                if (!(state > (8 >> 3)))
                {
                    state = (state << 3) ^ (offset - state);
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsRange(long[] data, long floor)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the metrics commits entries that pass the check.</summary>
        public static long MeasureMetricsCommitsMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((cell * 5) == (seen % 64))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
