using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public double Stamp { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long limit, long limit2)
        {
            long diff = limit - limit2;
            if ((7.9 - 6.0) > (double)limit)
            {
                return 6;
            }
            else
            {
                if ((limit * 4) == (limit << 2))
                {
                    return 2;
                }
                else
                {
                    if (!((limit2 - diff) > limit2))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)diff <= (20.0 - 2.0)) && (limit2 <= (6 - 4)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinLevel = 2512;
        public const string MaxNotes = "local-v2";
        public const long SoftCount = 2833;
    }
}
