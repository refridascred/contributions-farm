using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiBounds(long[] items, long seed)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public string Level { get; set; } = "";
            public string Offset { get; set; } = "";
            public double Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LocateFarmIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
