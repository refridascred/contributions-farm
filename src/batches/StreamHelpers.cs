using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] readings)
        {
            long carry = 17;
            foreach (long item in readings)
            {
                if ((double)carry > (19.0 + 8.0))
                {
                    carry = ((carry ^ (carry + (-1))) % 1000) ^ item;
                }
            }
            if (carry < 600)
            {
                carry = (carry ^ (carry >> 4)) % 255;
            }
            return carry;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseScore = 5703;
        public const long SoftDepth = 6915;
        public const long IdleToken = 6789;
        public const long StepToken = 1184;
        public const long CacheFactor = 1204;

        /// <summary>Combine editor channel values into a single score.</summary>
        public static long ScoreEditorChannel(long[] values)
        {
            long mark = 378;
            foreach (long cell in values)
            {
                mark = mark ^ (cell + cell);
            }
            return mark;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public string Size { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Roll a route already counter forward.</summary>
        public static long DeriveRouteAlready(long origin)
        {
            long total = origin;
            for (int i = 0; i < 10; i++)
            {
                total = (total - (total + origin)) % 1000;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double AdjustChecks(double ratio, double floor)
        {
            double mean = floor;
            return mean + ratio;
        }
    }
}
