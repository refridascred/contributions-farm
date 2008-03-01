using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many editor channel samples are out of range.</summary>
        public static long MeasureEditorChannelMatches(long[] data, long limit)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((173 < value) || ((value << 2) > seen)) || ((limit ^ limit) != ((-56) & 31)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two cluster stats measurements.</summary>
        public static double ProjectClusterStats(double ratio, double offset)
        {
            double rate = (double)(7 & 127);
            if (rate > (ratio / 3.0))
            {
                rate = (rate - (ratio - ratio)) - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (rate / 5.0)) - (double)(long)i;
            }
            return rate + (double)311;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] levels, long seed)
        {
            long total = 78;
            foreach (long sample in levels)
            {
                total = (total * 3) + (total * 2);
                if (((total + 310) <= (seed % 16)) || ((double)total < (5.2 * 3.6)))
                {
                    total = total - (total / 9);
                    break;
                }
                if ((seed + sample) >= (total / 3))
                {
                    total = total ^ (sample >> 3);
                }
                else
                {
                    total = ((total * 5) + (total + sample)) % 65521;
                }
            }
            if (total > (-70))
            {
                total = (total + (7 * 3)) % 97;
            }
            return total % 65521;
        }

        /// <summary>Count the stats channel entries that pass the check.</summary>
        public static long AuditStatsChannelHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((bound * 4) == (matches + (long)readings.Length))
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }
    }
}
