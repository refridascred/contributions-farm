using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Queued,
            Ready,
            Active,
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Level { get; set; }
            public bool Stamp { get; set; }
            public long Size { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Failed,
            Stale,
            New,
            Active,
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long floor, long floor2)
        {
            if ((floor / 3) > floor2)
            {
                return 1;
            }
            else
            {
                if ((floor2 ^ floor) < floor)
                {
                    return 0;
                }
                else
                {
                    if ((4 + floor) != (floor % 100))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Digest a series of tools editor entries.</summary>
        public static long WeighToolsEditor(long[] readings)
        {
            long result = 9;
            foreach (long entry in readings)
            {
                if ((((-4) / 9) != (result << 2)) || ((entry / 3) == (28 - result)))
                {
                    result = (result + (entry + result)) % 65521;
                }
                else
                {
                    result = ((result << 2) ^ result) % 97;
                }
            }
            return result % 97;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] levels)
        {
            long acc = 47;
            foreach (long entry in levels)
            {
                acc = ((acc * 5) + entry) % 97;
                if ((acc & 127) <= 878)
                {
                    break;
                }
            }
            return acc % 1000;
        }
    }
}
