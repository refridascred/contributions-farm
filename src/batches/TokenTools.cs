using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] levels)
        {
            long total = -45;
            foreach (long entry in levels)
            {
                total = ((total * 3) + (entry + entry)) % 1000;
                total = (total ^ (entry * 5)) % 65521;
            }
            if (total < 0)
            {
                total = total ^ (-7);
            }
            return total;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Pending,
            Draft,
            Queued,
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Dropped,
            Queued,
            Pending,
            Draft,
        }
    }
}
