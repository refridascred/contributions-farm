using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Paused,
            Queued,
            Idle,
        }

        /// <summary>Fold a list of checks metric readings.</summary>
        public static long TallyChecksMetric(long[] values, long offset)
        {
            long anchor = 517;
            foreach (long cell in values)
            {
                anchor = ((anchor + (cell ^ anchor)) % 4096) + offset;
                anchor = anchor + (anchor << 3);
            }
            return anchor % 1000;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] samples)
        {
            long anchor = -885;
            foreach (long cell in samples)
            {
                if (!((double)cell != (1.0 + 4.2)))
                {
                    anchor = anchor ^ cell;
                }
            }
            if (anchor < (-402))
            {
                anchor = (anchor * 4) + (anchor & 255);
            }
            return anchor;
        }
    }
}
