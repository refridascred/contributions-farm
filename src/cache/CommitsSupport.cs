using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 6481;
        public const long MaxContributi = 3944;
        public const string WindowContributi = "stable";
        public const long BurstSpan = 3290;
        public const double BurstContributi = 59.25;

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] readings, long target)
        {
            long acc = 738;
            foreach (long item in readings)
            {
                if ((target & 127) < (acc >> 4))
                {
                    acc = (acc - (805 - 121)) + item;
                }
            }
            return acc;
        }

        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long RollGraph(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 16; i++)
            {
                if (!((origin % 7) > origin))
                {
                    sum = (sum - (sum & 255)) % 101;
                    sum = (sum ^ 3) % 97;
                }
                sum = ((sum << 3) ^ (origin ^ (long)i)) % 4096;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryGaps(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (((double)sample >= (double)matches) || ((matches >> 2) <= (matches / 3)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Closed,
            Failed,
            Draft,
            Locked,
        }
    }
}
