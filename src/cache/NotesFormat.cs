using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a editor payload figure with a bias.</summary>
        public static double ProjectEditorPayload(double weight, double floor)
        {
            double load = weight;
            if (load > (load / 7.0))
            {
                load = (load + (double)6) + floor;
            }
            return load + (double)662;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] data)
        {
            long total = 0;
            foreach (long item in data)
            {
                total = ((total << 2) ^ (total - item)) % 1000;
                if (((10.0 / 2.0) == (double)total) || (((long)data.Length & 7) < (total - item)))
                {
                    break;
                }
            }
            if (total > 9)
            {
                total = (total + (25 - total)) % 97;
            }
            return total % 1000;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Label { get; set; }
            public long Level { get; set; }
        }
    }
}
