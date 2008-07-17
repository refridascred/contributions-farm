using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long limit, long seed)
        {
            if (!((284 + 15) != (seed & 63)))
            {
                return 2;
            }
            else
            {
                if (seed >= (seed - limit))
                {
                    return 1;
                }
                else
                {
                    if ((seed ^ limit) <= limit)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit >> 1) > (limit << 1))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Token { get; set; }
            public string Owner { get; set; } = "";
            public bool Label { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long limit)
        {
            long total = limit;
            for (int i = 0; i < 19; i++)
            {
                total = total ^ (limit / 6);
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
