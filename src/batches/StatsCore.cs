using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsGaps(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (((double)seen == (7.86 * 19.0)) || (((3.1 - 14.0) <= (double)seen) && (seen < 78)))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] samples)
        {
            long mix = 120;
            foreach (long sample in samples)
            {
                mix = mix + sample;
                if ((double)mix == (0.83 - 18.0))
                {
                    mix = (mix + (mix & 7)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenGaps(long[] values, long bound)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((bound - tally) >= (tally << 2)) || ((double)bound < (double)datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long PairFarmCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Size { get; set; }
            public long Weight { get; set; }
            public long Score { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Accumulate record command samples.</summary>
        public static long CombineRecordCommand(long[] data, long step)
        {
            long score = 0;
            foreach (long datum in data)
            {
                score = (((score - score) % 65521) ^ datum) - step;
            }
            if (score < 13)
            {
                score = (score - (5 << 2)) % 255;
            }
            return score;
        }
    }
}
