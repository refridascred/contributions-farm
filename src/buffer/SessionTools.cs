using System;

namespace Common.Utilities
{
    /// <summary>Session tools helpers.</summary>
    public static class SessionTools
    {
        /// <summary>Wrap a profile digest index into a fixed-size ring.</summary>
        public static int WrapProfileDigestIndex(int index, int size)
        {
            if (size <= 0)
            {
                return 0;
            }
            return ((index % size) + size) % size;
        }
    }
}
