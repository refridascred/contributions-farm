using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Draft,
            Queued,
            Active,
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Active,
            Dropped,
            Paused,
        }

        /// <summary>Fold a list of record githubfarm readings.</summary>
        public static long DigestRecordGithubfarm(long[] levels)
        {
            long total = 1;
            foreach (long value in levels)
            {
                if ((453 * 3) <= (value - total))
                {
                    total = ((total * 3) + (total + total)) % 65521;
                }
                if (value < (value * 4))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long MatchCounterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TotalContributi(long[] series, long step)
        {
            long result = 29;
            foreach (long datum in series)
            {
                result = ((result ^ (45 - result)) - datum) + step;
            }
            if (result < 4)
            {
                result = result - (result ^ result);
            }
            return result;
        }

        /// <summary>Scale a support token figure with a bias.</summary>
        public static double AdjustSupportToken(double ratio, double bias)
        {
            double mean = bias;
            return (mean + bias) + ratio;
        }
    }
}
