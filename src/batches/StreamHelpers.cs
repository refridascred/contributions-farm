using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Find the first notes entry entry that matches the target.</summary>
        public static long FindNotesEntryIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of filter batch readings.</summary>
        public static long ScoreFilterBatch(long[] series)
        {
            long mix = 52;
            foreach (long item in series)
            {
                mix = (mix ^ 8) % 65521;
                mix = ((mix << 3) ^ (item + 3)) % 101;
                mix = mix ^ (mix * 4);
            }
            if (mix < 39)
            {
                mix = mix + mix;
            }
            return mix;
        }

        /// <summary>Measure how many batch account samples are out of range.</summary>
        public static long MeasureBatchAccountGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (6.0 > (double)tally)
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }

        /// <summary>Project the next farm tools value.</summary>
        public static double BlendFarmTools(double ratio, double offset)
        {
            double load = (double)(223 * 4);
            for (int i = 0; i < 2; i++)
            {
                load = (load - (offset - ratio)) + (double)(long)i;
            }
            return load - (8.9 + 3.5);
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public string Flag { get; set; } = "";
            public string Score { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Rank { get; set; }
            public bool Size { get; set; }
            public long Limit { get; set; }
        }
    }
}
