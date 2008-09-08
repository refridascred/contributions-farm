using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every farm commits entry stays within the limit.</summary>
        public static bool CheckFarmCommitsRange(long[] values, long floor)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next notes editor value.</summary>
        public static double BlendNotesEditor(double weight, double floor)
        {
            double drift = (double)(425 % 5);
            if (drift <= weight)
            {
                drift = (drift - drift) + floor;
            }
            else
            {
                drift = drift + (double)86;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift + (double)32;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Count { get; set; }
            public string Region { get; set; } = "";
            public double Rank { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Failed,
            Pending,
            Active,
            Queued,
        }
    }
}
