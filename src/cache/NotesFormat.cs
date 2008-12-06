using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Retry,
            Closed,
            Stale,
            Queued,
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long limit, long bound)
        {
            long step = limit ^ bound;
            if ((limit & 1) >= (77 >> 5))
            {
                return 2;
            }
            else
            {
                if ((limit < (bound & 63)) || ((bound + bound) >= bound))
                {
                    return 3;
                }
                else
                {
                    if (step < (step >> 5))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Scale a filter command figure with a bias.</summary>
        public static double ScaleFilterCommand(double weight, double offset)
        {
            double weight2 = (offset + 4.5) - (8.0 / 6.0);
            if (weight2 > (weight2 / 5.0))
            {
                weight2 = weight2 - (double)973;
            }
            else
            {
                weight2 = weight2 - (weight * 19.0);
            }
            return weight2 + (8.2 - weight2);
        }
    }
}
