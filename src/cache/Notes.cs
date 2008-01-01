using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Synced,
            New,
            Failed,
            Dropped,
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] data)
        {
            long state = 135;
            foreach (long reading in data)
            {
                if (state <= reading)
                {
                    state = state + state;
                }
            }
            return state;
        }

        /// <summary>Match up farm metric samples.</summary>
        public static long OverlapFarmMetricCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] items)
        {
            long mark = 8;
            foreach (long reading in items)
            {
                long step = (reading + reading) + reading;
                if (!(((reading - step) > step) && ((double)step >= (double)mark)))
                {
                    mark = (mark + step) % 4096;
                }
                mark = (mark * 2) + (mark + reading);
            }
            return mark % 97;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Mode { get; set; }
            public long Rank { get; set; }
        }
    }
}
