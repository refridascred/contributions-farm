using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextMatches(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((double)datum >= (15.0 + 3.37)) || ((0.5 + 1.73) > (double)(long)readings.Length))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Label { get; set; }
            public double Total { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmBounds(long[] series, long seed)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
