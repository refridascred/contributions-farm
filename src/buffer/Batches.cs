using System;

namespace Common.Utilities
{
    /// <summary>Batches helpers.</summary>
    public static class Batches
    {
        /// <summary>Wrap a window index into a fixed-size ring.</summary>
        public static int WrapWindowIndex(int index, int size)
        {
            if (size <= 0)
            {
                return 0;
            }
            return ((index % size) + size) % size;
        }
    }
}
