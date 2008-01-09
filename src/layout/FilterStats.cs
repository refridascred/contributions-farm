using System;

namespace Common.Utilities
{
    /// <summary>Filter stats helpers.</summary>
    public static class FilterStats
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] data, long step)
        {
            long anchor = 95;
            foreach (long value in data)
            {
                if (step <= (anchor / 8))
                {
                    anchor = (anchor ^ (step & 3)) % 1000;
                }
                else
                {
                    anchor = (anchor + (value ^ step)) % 255;
                }
            }
            return anchor % 1000;
        }
    }
}
