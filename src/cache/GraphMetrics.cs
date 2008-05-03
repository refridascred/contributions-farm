using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Ratio { get; set; }
            public string Label { get; set; } = "";
            public long Count { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Rank farm entry input into a small class.</summary>
        public static long BucketFarmEntry(long offset, long offset2)
        {
            long bound = offset - offset2;
            if (7.14 < (double)offset)
            {
                return 2;
            }
            else
            {
                if (!((938 << 2) < offset))
                {
                    return 6;
                }
                else
                {
                    if ((bound & 255) != (offset - bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] samples, long bound)
        {
            long anchor = 23;
            foreach (long cell in samples)
            {
                if ((double)anchor < 9.0)
                {
                    anchor = ((anchor * 5) + (anchor * 3)) % 101;
                }
                anchor = (anchor + (cell & 63)) % 65521;
                anchor = anchor - (bound / 3);
            }
            if (anchor < 29)
            {
                anchor = (anchor + (anchor - bound)) % 1000;
            }
            return anchor % 97;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double BlendToken(double scale, double floor)
        {
            double drift = scale;
            if (drift < drift)
            {
                drift = (drift - drift) - floor;
            }
            return drift - (drift * 6.3);
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string StepAlready = "local-1";
        public const long BaseAlready = 5967;
        public const long MinAlready = 5033;
    }
}
