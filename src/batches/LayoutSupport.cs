using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many schema record samples are out of range.</summary>
        public static long CountSchemaRecordGaps(long[] values, long step)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((4.07 + 3.8) < (double)value)
                {
                    tally = (tally + 2) + step;
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 3772;
        public const long BurstNotes = 1141;
        public const long DefaultSize = 2600;
        public const long MinSize = 4027;

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] readings, long step)
        {
            long mark = 4;
            foreach (long item in readings)
            {
                mark = ((mark << 2) ^ ((long)readings.Length * 4)) % 65521;
                if ((25 & 255) >= (step / 9))
                {
                    mark = ((mark * 2) + (item + item)) % 255;
                }
            }
            return mark % 4096;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public double Limit { get; set; }
            public long Stamp { get; set; }
            public double Size { get; set; }
            public long Level { get; set; }
        }
    }
}
