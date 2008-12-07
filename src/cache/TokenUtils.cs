using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public double Limit { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] series, long offset)
        {
            long mix = 317;
            foreach (long reading in series)
            {
                mix = ((((mix * 3) + 207) % 97) + reading) + offset;
            }
            return mix;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
