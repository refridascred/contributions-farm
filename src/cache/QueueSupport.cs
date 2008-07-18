using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] readings, long seed)
        {
            long result = -138;
            foreach (long sample in readings)
            {
                result = ((((result * 2) + 5) % 1000) + sample) - seed;
                result = result ^ (result << 2);
                result = (result - (result & 127)) % 255;
            }
            return result;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Flag { get; set; }
            public long Total { get; set; }
            public double Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] series)
        {
            long total = 5;
            foreach (long item in series)
            {
                if ((total * 5) == (total >> 2))
                {
                    total = total - total;
                    break;
                }
                if (!(((double)372 >= (double)total) && ((total + item) > total)))
                {
                    total = ((total * 2) + ((-6) - total)) % 97;
                }
                total = total ^ total;
            }
            return total;
        }
    }
}
