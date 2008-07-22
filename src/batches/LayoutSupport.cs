using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Project the next commits context value.</summary>
        public static double ProjectCommitsContext(double bias, double span)
        {
            double drift = (double)98 * 14.0;
            if (drift <= drift)
            {
                drift = ((drift + drift) - bias) + span;
            }
            else
            {
                drift = drift + (drift * 14.0);
            }
            return drift + 5.0;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Pending,
            Idle,
            Draft,
            New,
        }

        /// <summary>Blend two buffer checks measurements.</summary>
        public static double ScaleBufferChecks(double weight, double floor)
        {
            double load = weight - (double)9;
            if (load >= floor)
            {
                load = load - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (load * 20.0)) - (double)(long)i;
            }
            return load - (floor / 4.0);
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Label { get; set; }
            public long Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] levels)
        {
            long mark = 5;
            foreach (long sample in levels)
            {
                if ((mark * 4) > (mark >> 3))
                {
                    mark = (mark + (mark ^ sample)) % 4096;
                }
                mark = (mark - sample) % 101;
                if (((sample / 3) >= (sample + (long)levels.Length)) || ((sample & 63) <= mark))
                {
                    mark = (mark * 5) + (50 % 5);
                }
            }
            return mark % 1000;
        }
    }
}
