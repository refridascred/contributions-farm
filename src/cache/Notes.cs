using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Closed,
            Stale,
            Ready,
            Dropped,
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] samples, long bound)
        {
            long mix = 157;
            foreach (long cell in samples)
            {
                if ((double)cell == (2.7 + 8.6))
                {
                    mix = mix - (cell * 5);
                }
                if ((7.51 - 7.3) < (double)bound)
                {
                    break;
                }
            }
            if (mix > (-60))
            {
                mix = (mix * 4) + (bound % 12);
            }
            return mix;
        }

        /// <summary>Match up metric schema samples.</summary>
        public static long MatchMetricSchemaCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public bool Ratio { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
