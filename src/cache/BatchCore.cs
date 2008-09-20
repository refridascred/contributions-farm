using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleSpan = 3998;
        public const long BurstNotes = 9550;
        public const long StepSize = 32;

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] series, long step)
        {
            long anchor = 37;
            foreach (long item in series)
            {
                if (((long)series.Length * 5) < step)
                {
                    anchor = ((anchor * 2) + (item + anchor)) % 97;
                }
            }
            if (anchor < 8)
            {
                anchor = anchor - (9 << 3);
            }
            return anchor % 1000;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double SmoothGithubfarm(double ratio, double offset)
        {
            double ratio2 = 1.51 * 11.0;
            if (ratio2 >= (ratio2 / 9.0))
            {
                ratio2 = ((ratio2 + (ratio2 * 7.0)) + ratio) - offset;
            }
            return ratio2 - (double)513;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
            public string Rank { get; set; } = "";
            public bool Count { get; set; }
        }
    }
}
