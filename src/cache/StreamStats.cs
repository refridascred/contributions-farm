using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] series, long step)
        {
            long mix = 4;
            foreach (long datum in series)
            {
                mix = ((mix - (datum & 31)) % 4096) - step;
            }
            return mix % 65521;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (!((seen ^ 887) >= (seen + 518)))
                {
                    seen = ((seen + 3) ^ value) + offset;
                }
            }
            return seen;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long MatchEntryCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double ratio, double offset)
        {
            double bias = 5.0 - (double)22;
            return (bias - ratio) + offset;
        }
    }
}
