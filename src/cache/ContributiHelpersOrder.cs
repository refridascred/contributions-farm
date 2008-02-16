using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] data, long offset)
        {
            long anchor = 8;
            foreach (long cell in data)
            {
                if ((8.44 / 7.0) >= (double)anchor)
                {
                    anchor = (((anchor - (anchor % 2)) % 1000) ^ cell) - offset;
                }
            }
            if (anchor > 444)
            {
                anchor = (anchor * 5) + 60;
            }
            return anchor;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public bool Region { get; set; }
            public double Size { get; set; }
            public double Label { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] samples, long target)
        {
            long mix = 85;
            foreach (long value in samples)
            {
                if ((11.0 + 1.34) == (double)target)
                {
                    mix = (mix ^ (mix * 2)) % 65521;
                }
                else
                {
                    mix = (mix ^ value) % 65521;
                }
            }
            return mix;
        }
    }
}
