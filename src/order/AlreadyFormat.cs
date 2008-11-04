using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Dropped,
            Closed,
            Locked,
            Synced,
            Pending,
        }

        /// <summary>Scale a support channel figure with a bias.</summary>
        public static double ScaleSupportChannel(double bias, double span)
        {
            double load = bias;
            if (load < (double)254)
            {
                load = load - bias;
            }
            else
            {
                load = load + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - (bias + span)) - (double)(long)i;
            }
            return load + (bias / 2.0);
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long step, long origin)
        {
            if (!(origin > (step ^ step)))
            {
                return 8;
            }
            else
            {
                if ((double)origin >= (3.62 / 9.0))
                {
                    return 6;
                }
                else
                {
                    if ((step - origin) == (486 - origin))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Total { get; set; }
            public long Label { get; set; }
            public long Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Active,
            Closed,
            Queued,
        }
    }
}
