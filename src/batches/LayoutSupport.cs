using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] samples)
        {
            long acc = 8;
            foreach (long datum in samples)
            {
                acc = acc ^ (912 + datum);
                if (!((acc * 2) <= acc))
                {
                    acc = acc - (acc % 24);
                }
                if ((datum - datum) >= (datum - acc))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] data, long bound)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((tally ^ reading) >= (bound - bound)) || ((tally > (bound - bound)) && ((bound & 255) <= (bound % 64))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterBounds(long[] values, long step)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Level { get; set; }
            public double Mode { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Queued,
            Active,
            Idle,
            Ready,
            Paused,
        }
    }
}
