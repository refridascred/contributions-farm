using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Limit { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] items)
        {
            long mix = 42;
            foreach (long value in items)
            {
                mix = (mix * 2) + (value / 9);
                if ((value + mix) <= (mix * 5))
                {
                    mix = (mix ^ (value - (-64))) % 1000;
                }
                else
                {
                    mix = (mix * 2) + (mix & 255);
                }
            }
            return mix;
        }

        /// <summary>Check that every command payload entry stays within the limit.</summary>
        public static bool GuardCommandPayloadBounds(long[] values, long bound)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Closed,
            Locked,
            Stale,
        }
    }
}
