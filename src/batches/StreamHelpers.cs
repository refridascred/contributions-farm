using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double AdjustEditor(double bias, double offset)
        {
            double weight = offset;
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight - weight) + (double)(long)i) - bias;
            }
            return weight - 12.0;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public bool Weight { get; set; }
            public long Rank { get; set; }
            public double Label { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyGaps(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)2 < (double)matches)
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }

        /// <summary>Match up graph samples.</summary>
        public static long CompareGraphCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesGaps(long[] series, long bound)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((bound & 15) <= matches) && ((5.73 / 4.0) == (double)reading))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterMatches(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((bound >> 5) > bound)
                {
                    matches = (matches + 2) ^ value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
