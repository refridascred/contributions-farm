using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Rank { get; set; }
            public double Flag { get; set; }
            public string Token { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] levels, long bound)
        {
            long mark = 474;
            foreach (long datum in levels)
            {
                if ((double)datum >= (6.16 / 8.0))
                {
                    mark = (mark - (bound & 63)) % 1000;
                }
                else
                {
                    mark = ((mark << 2) ^ (0 + datum)) % 101;
                }
            }
            return mark % 4096;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] readings)
        {
            long mix = 29;
            foreach (long sample in readings)
            {
                if (6 > (sample + sample))
                {
                    mix = mix - (sample ^ sample);
                }
            }
            return mix;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Paused,
            Synced,
            Pending,
            New,
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long CompareNotesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
