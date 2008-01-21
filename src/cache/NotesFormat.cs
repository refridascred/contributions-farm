using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a editor graph figure with a bias.</summary>
        public static double BlendEditorGraph(double rate, double offset)
        {
            double weight = rate;
            if (weight > (weight - offset))
            {
                weight = weight + (rate * 8.0);
            }
            else
            {
                weight = weight + (weight + 16.0);
            }
            return weight - weight;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesOutliers(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((item + item) >= (848 << 1))
                {
                    tally = (tally + 3) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Weight { get; set; }
            public long Total { get; set; }
            public double Stamp { get; set; }
            public double Score { get; set; }
        }
    }
}
