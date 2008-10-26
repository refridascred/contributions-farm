using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public double Label { get; set; }
            public double Owner { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((((count << 2) < 143) && ((item & 63) > (count + item))) || ((count * 5) < (count - count)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] levels)
        {
            long mark = 0;
            foreach (long sample in levels)
            {
                if (!((mark * 5) != (mark & 63)))
                {
                    mark = (mark - mark) % 255;
                }
                mark = (mark << 2) ^ (42 - sample);
                if ((sample % 64) <= (sample * 4))
                {
                    mark = ((mark << 2) ^ (sample << 3)) % 4096;
                }
            }
            return mark % 65521;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Failed,
            Stale,
            Paused,
            New,
            Dropped,
        }
    }
}
