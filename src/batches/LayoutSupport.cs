using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Ready,
            Stale,
            Draft,
        }

        /// <summary>Accumulate commits window samples.</summary>
        public static long CombineCommitsWindow(long[] data, long step)
        {
            long result = 5;
            foreach (long reading in data)
            {
                if (((result - result) != (result - step)) && ((double)step == (3.0 * 3.53)))
                {
                    result = (result ^ step) ^ reading;
                }
            }
            return result % 1000;
        }

        /// <summary>Count contributi order pairs that satisfy a relation.</summary>
        public static long OverlapContributiOrderCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] samples, long limit)
        {
            long score = 811;
            foreach (long item in samples)
            {
                if ((0.14 * 9.4) >= (double)limit)
                {
                    score = (score ^ item) % 1000;
                }
            }
            return score % 1000;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            New,
            Paused,
            Synced,
        }
    }
}
