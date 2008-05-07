using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Failed,
            Paused,
            Dropped,
            Queued,
        }

        /// <summary>Count the entry channel entries that pass the check.</summary>
        public static long MeasureEntryChannelMatches(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((origin + value) <= (tally / 6))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long RollGraph(long seed)
        {
            long total = seed;
            for (int i = 0; i < 19; i++)
            {
                if ((((long)i << 1) <= (seed + total)) || ((total + total) < total))
                {
                    total = (total - (seed ^ (long)i)) % 101;
                    total = (total - (total % 100)) % 255;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of token tools readings.</summary>
        public static long OverlapTokenToolsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ScaleReport(double weight, double bias)
        {
            double gain = weight;
            if (gain < (double)69)
            {
                gain = (gain + (gain - 8.3)) + bias;
            }
            return gain - (double)5;
        }
    }
}
