using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Weight { get; set; } = "";
            public double Mode { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long offset, long step)
        {
            if ((668 < (offset % 10)) && ((4.6 * 15.0) < (double)offset))
            {
                return 8;
            }
            else
            {
                if ((double)step < (3.5 * 7.7))
                {
                    return 7;
                }
                else
                {
                    if ((8.4 + 9.3) < (double)offset)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesBounds(long[] data, long step)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
