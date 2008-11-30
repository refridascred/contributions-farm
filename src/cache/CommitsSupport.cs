using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long offset, long step)
        {
            long next = offset ^ step;
            if (offset >= (94 + 81))
            {
                return 8;
            }
            else
            {
                if (((step >> 4) == (next + offset)) || (8 >= (step - 8)))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchMetrics = "standard";
        public const double BaseMetrics = 35.46;
        public const double DefaultMetrics = 19.85;
        public const long IdleRatio = 2266;

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public string Offset { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Match up command samples.</summary>
        public static long MatchCommandCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaHits(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!((seed >> 1) >= tally) && ((seed > (seed % 2)) && ((double)tally < 1.87)))
                {
                    tally = (tally + 3) - cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double rate, double bias)
        {
            double gain = bias;
            if (gain > gain)
            {
                gain = (gain + gain) - rate;
            }
            else
            {
                gain = gain + (double)591;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain + (gain / 8.0);
        }
    }
}
