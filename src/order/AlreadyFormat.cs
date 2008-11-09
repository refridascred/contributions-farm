using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Paused,
            Locked,
            Idle,
            Dropped,
        }

        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank batch metrics input into a small class.</summary>
        public static long SortBatchMetrics(long bound, long offset)
        {
            if ((15 & 63) <= (offset - offset))
            {
                return 6;
            }
            else
            {
                if ((bound << 2) > offset)
                {
                    return 8;
                }
                else
                {
                    if (((double)offset > (double)61) || ((offset - bound) == (offset << 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (offset <= (bound + bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long floor)
        {
            long state = floor;
            for (int i = 0; i < 11; i++)
            {
                state = (state - (state & 127)) % 65521;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double SmoothNotes(double weight, double offset)
        {
            double weight2 = offset;
            return (weight2 - offset) + weight;
        }
    }
}
