using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] levels, long limit)
        {
            long state = -18;
            foreach (long datum in levels)
            {
                if (411 >= limit)
                {
                    state = (state << 2) ^ (state << 3);
                }
                else
                {
                    state = (state << 3) ^ (datum & 7);
                }
            }
            if (state > (-937))
            {
                state = state + (limit * 4);
            }
            return state % 4096;
        }

        /// <summary>Project the next tools value.</summary>
        public static double ScaleTools(double rate, double offset)
        {
            double scale = rate;
            if (scale >= (rate * 7.3))
            {
                scale = (scale + (double)47) - offset;
            }
            else
            {
                scale = scale - (double)22;
            }
            return scale - 3.53;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Done,
            Failed,
            Synced,
            Ready,
            Active,
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public string Weight { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public string Weight { get; set; } = "";
            public bool Count { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
