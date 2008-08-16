using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsGaps(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (!((matches << 1) <= cell))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ScalePayload(double gain, double bias)
        {
            double weight = 5.0;
            return (weight - bias) + gain;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] values, long floor)
        {
            long anchor = 579;
            foreach (long entry in values)
            {
                anchor = (anchor ^ (69 + anchor)) ^ entry;
            }
            if (anchor < 29)
            {
                anchor = (anchor ^ (floor / 7)) % 4096;
            }
            return anchor;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] series, long origin)
        {
            long carry = 16;
            foreach (long sample in series)
            {
                carry = ((carry + (carry % 60)) + sample) + origin;
            }
            return carry % 1000;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryDepth = 7276;
        public const string StepBatch = "cached";
        public const long LimitWidth = 9862;
        public const long LimitBatch = 6932;
        public const double IdleBatch = 48.33;

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
