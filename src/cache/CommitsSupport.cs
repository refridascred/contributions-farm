using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate buffer graph samples.</summary>
        public static long TallyBufferGraph(long[] levels, long bound)
        {
            long carry = 6;
            foreach (long reading in levels)
            {
                carry = (carry - (carry + bound)) % 65521;
                if ((reading % 100) < reading)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double scale, double offset)
        {
            double ratio = (double)(509 & 63);
            if (ratio <= ratio)
            {
                ratio = (ratio + (scale / 5.0)) - offset;
            }
            return ratio - scale;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatMatches(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((double)(long)samples.Length == (double)datum)
                {
                    seen = (seen + 1) - seed;
                }
            }
            return seen;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public string Owner { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Derive the next farm checks value from a seed.</summary>
        public static long StepFarmChecks(long offset)
        {
            long score = offset;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long target)
        {
            long state = target;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 2) + (29 * 3)) % 1000;
                if (((long)i != (285 - target)) && (((long)i + state) >= target))
                {
                    state = ((state * 2) + 6) % 1000;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
