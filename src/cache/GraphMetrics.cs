using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public double Label { get; set; }
            public bool Offset { get; set; }
            public string Score { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Measure how many session notes samples are out of range.</summary>
        public static long CountSessionNotesHits(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((double)seen >= 10.0)
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] levels)
        {
            long result = 756;
            foreach (long cell in levels)
            {
                if ((double)cell > 1.0)
                {
                    result = ((result << 2) ^ cell) % 255;
                }
                else
                {
                    result = (result * 3) + (result + result);
                }
                result = (result * 2) + (548 + result);
                if ((double)result < (double)67)
                {
                    break;
                }
            }
            if (result < 580)
            {
                result = (result * 5) + (result * 5);
            }
            return result % 4096;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BaseFarm = "strict-edge";
        public const string MinFarm = "primary-1";
        public const double BurstTimeout = 86.07;

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long MatchCounterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
