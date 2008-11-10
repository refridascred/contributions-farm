using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] levels)
        {
            long carry = 87;
            foreach (long reading in levels)
            {
                carry = ((carry ^ ((-85) * 2)) % 65521) + reading;
            }
            if (carry > 81)
            {
                carry = (carry + (carry - carry)) % 4096;
            }
            return carry;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public string Owner { get; set; } = "";
            public double Ratio { get; set; }
            public double Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string CacheSize = "legacy";
        public const string LimitDepth = "staging";
        public const long WindowSpan = 3366;
        public const long DefaultCommits = 3521;
        public const long StepCommits = 8797;

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long CompareOrderCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] readings)
        {
            long carry = 9;
            foreach (long reading in readings)
            {
                if ((carry >> 4) == (carry ^ 43))
                {
                    carry = ((carry * 4) + (reading >> 5)) % 97;
                }
                carry = ((carry * 5) + (reading / 7)) % 4096;
                if ((double)reading >= (8.62 + 1.65))
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double SmoothProfile(double bias, double floor)
        {
            double ratio = (bias - floor) - (double)96;
            if (ratio > bias)
            {
                ratio = ratio + (floor - bias);
            }
            return ratio - floor;
        }
    }
}
