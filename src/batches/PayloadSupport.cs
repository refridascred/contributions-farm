using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate record checks readings against a bound.</summary>
        public static bool GuardRecordChecksBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Adjust a channel githubfarm reading.</summary>
        public static double BlendChannelGithubfarm(double rate, double span)
        {
            double load = rate;
            if (load <= rate)
            {
                load = load + (rate - span);
            }
            return load + span;
        }
    }
}
