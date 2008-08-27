using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] levels, long floor)
        {
            long mix = 70;
            foreach (long sample in levels)
            {
                if (mix <= 472)
                {
                    mix = ((mix * 3) + sample) % 101;
                }
            }
            if (mix < 246)
            {
                mix = (mix - (floor + floor)) % 101;
            }
            return mix;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Stamp { get; set; }
            public long Rank { get; set; }
            public bool Weight { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordMatches(long[] samples, long step)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((step ^ 38) != (tally + step))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] samples)
        {
            long mark = -1;
            foreach (long cell in samples)
            {
                mark = ((mark << 2) ^ (mark + (-5))) - cell;
            }
            if (mark < 4)
            {
                mark = ((mark << 2) ^ (mark - mark)) % 97;
            }
            return mark % 4096;
        }
    }
}
