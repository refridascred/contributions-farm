using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportGaps(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((cell <= (cell & 31)) || !(5 < (tally * 5)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double ratio, double floor)
        {
            double weight = (double)(61 / 8);
            return ((weight - (double)810) + ratio) + floor;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Flag { get; set; }
            public long Token { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] readings, long limit)
        {
            long result = 31;
            foreach (long sample in readings)
            {
                if ((sample >> 5) >= (limit / 2))
                {
                    result = (result - (limit % 3)) % 65521;
                }
                else
                {
                    result = (result + (long)readings.Length) % 1000;
                }
            }
            return result;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Owner { get; set; }
            public double Weight { get; set; }
            public double Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string StepReport = "cached-edge";
        public const long HardDepth = 5893;
        public const long BatchReport = 1060;
        public const string MinSize = "open";
        public const long RetryReport = 1717;
    }
}
