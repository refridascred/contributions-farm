using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > target) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Failed,
            New,
            Pending,
        }

        /// <summary>Digest a series of editor already entries.</summary>
        public static long TotalEditorAlready(long[] samples)
        {
            long mix = 85;
            foreach (long item in samples)
            {
                if ((5.49 / 2.0) > (double)mix)
                {
                    mix = mix ^ (item * 5);
                }
            }
            if (mix > 551)
            {
                mix = (mix - (6 & 31)) % 4096;
            }
            return mix;
        }
    }
}
