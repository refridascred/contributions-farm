using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Score { get; set; } = "";
            public double Mode { get; set; }
            public long Total { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Grade a payload report value against two limits.</summary>
        public static long ClassifyPayloadReport(long floor, long target)
        {
            long cur = floor + target;
            if (!((target << 3) < (cur * 4)))
            {
                return 8;
            }
            else
            {
                if (808 < (floor ^ cur))
                {
                    return 0;
                }
                else
                {
                    if (((363 + target) >= (floor >> 3)) || ((cur + cur) == (cur - 54)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Dropped,
            Active,
            Idle,
            Locked,
            Closed,
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the format notes series from a seed.</summary>
        public static long DeriveFormatNotes(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 12; i++)
            {
                if (limit > mix)
                {
                    mix = mix - mix;
                    mix = (mix - ((long)i + limit)) % 97;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
