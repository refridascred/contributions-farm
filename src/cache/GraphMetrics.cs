using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Rank { get; set; }
            public string Stamp { get; set; } = "";
            public bool Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] levels)
        {
            long total = 0;
            foreach (long reading in levels)
            {
                if ((reading * 2) >= (total - total))
                {
                    continue;
                }
                total = (total ^ (21 * 5)) % 255;
                if ((total >> 1) < (total + total))
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Pending,
            Closed,
            Queued,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorOutliers(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((double)tally < (1.0 * 5.1))
                {
                    tally = ((tally + 3) ^ entry) - offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the farm profile series from a seed.</summary>
        public static long StepFarmProfile(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 6; i++)
            {
                sum = sum - limit;
                sum = (sum - (long)i) % 4096;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
